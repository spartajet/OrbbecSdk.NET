namespace OrbbecSdk.NET.Enums
{
    public enum ob_data_tran_state
    {
        DATA_TRAN_STAT_STOPED       = 3,
        DATA_TRAN_STAT_DONE         = 2,
        DATA_TRAN_STAT_VERIFYING    = 1,
        DATA_TRAN_STAT_TRANSFERING  = 0,
        DATA_TRAN_ERR_BUSY          = -1,
        DATA_TRAN_ERR_UNSUPPORTED   = -2,
        DATA_TRAN_ERR_TRAN_FAILED   = -3,
        DATA_TRAN_ERR_VERIFY_FAILED = -4,
        DATA_TRAN_ERR_OTHER         = -5
    }
}