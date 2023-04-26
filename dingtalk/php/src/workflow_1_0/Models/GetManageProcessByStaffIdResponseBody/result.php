<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\GetManageProcessByStaffIdResponseBody;

use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @example 0
     *
     * @var int
     */
    public $attendanceType;

    /**
     * @example 通用审批
     *
     * @var string
     */
    public $flowTitle;

    /**
     * @example 2020-07-14 14:24:59
     *
     * @var string
     */
    public $gmtModified;

    /**
     * @example common
     *
     * @var string
     */
    public $iconName;

    /**
     * @example https://gw.alicdn.com/tfs/xxxx-112-112.png
     *
     * @var string
     */
    public $iconUrl;

    /**
     * @example true
     *
     * @var bool
     */
    public $newProcess;

    /**
     * @example PROC-44E84FC1-16E2-4A69-BB3C-xxxx
     *
     * @var string
     */
    public $processCode;
    protected $_name = [
        'attendanceType' => 'attendanceType',
        'flowTitle'      => 'flowTitle',
        'gmtModified'    => 'gmtModified',
        'iconName'       => 'iconName',
        'iconUrl'        => 'iconUrl',
        'newProcess'     => 'newProcess',
        'processCode'    => 'processCode',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->attendanceType) {
            $res['attendanceType'] = $this->attendanceType;
        }
        if (null !== $this->flowTitle) {
            $res['flowTitle'] = $this->flowTitle;
        }
        if (null !== $this->gmtModified) {
            $res['gmtModified'] = $this->gmtModified;
        }
        if (null !== $this->iconName) {
            $res['iconName'] = $this->iconName;
        }
        if (null !== $this->iconUrl) {
            $res['iconUrl'] = $this->iconUrl;
        }
        if (null !== $this->newProcess) {
            $res['newProcess'] = $this->newProcess;
        }
        if (null !== $this->processCode) {
            $res['processCode'] = $this->processCode;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return result
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['attendanceType'])) {
            $model->attendanceType = $map['attendanceType'];
        }
        if (isset($map['flowTitle'])) {
            $model->flowTitle = $map['flowTitle'];
        }
        if (isset($map['gmtModified'])) {
            $model->gmtModified = $map['gmtModified'];
        }
        if (isset($map['iconName'])) {
            $model->iconName = $map['iconName'];
        }
        if (isset($map['iconUrl'])) {
            $model->iconUrl = $map['iconUrl'];
        }
        if (isset($map['newProcess'])) {
            $model->newProcess = $map['newProcess'];
        }
        if (isset($map['processCode'])) {
            $model->processCode = $map['processCode'];
        }

        return $model;
    }
}
