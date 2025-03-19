<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models\GetDingReportDeptSummaryResponseBody;

use AlibabaCloud\Tea\Model;

class data extends Model
{
    /**
     * @example 123
     *
     * @var string
     */
    public $deptId;

    /**
     * @example 部门A
     *
     * @var string
     */
    public $deptName;

    /**
     * @example 100
     *
     * @var string
     */
    public $dingReportSendCnt;

    /**
     * @example 100
     *
     * @var string
     */
    public $dingReportSendUsrCnt;
    protected $_name = [
        'deptId' => 'deptId',
        'deptName' => 'deptName',
        'dingReportSendCnt' => 'dingReportSendCnt',
        'dingReportSendUsrCnt' => 'dingReportSendUsrCnt',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->deptId) {
            $res['deptId'] = $this->deptId;
        }
        if (null !== $this->deptName) {
            $res['deptName'] = $this->deptName;
        }
        if (null !== $this->dingReportSendCnt) {
            $res['dingReportSendCnt'] = $this->dingReportSendCnt;
        }
        if (null !== $this->dingReportSendUsrCnt) {
            $res['dingReportSendUsrCnt'] = $this->dingReportSendUsrCnt;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return data
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['deptId'])) {
            $model->deptId = $map['deptId'];
        }
        if (isset($map['deptName'])) {
            $model->deptName = $map['deptName'];
        }
        if (isset($map['dingReportSendCnt'])) {
            $model->dingReportSendCnt = $map['dingReportSendCnt'];
        }
        if (isset($map['dingReportSendUsrCnt'])) {
            $model->dingReportSendUsrCnt = $map['dingReportSendUsrCnt'];
        }

        return $model;
    }
}
