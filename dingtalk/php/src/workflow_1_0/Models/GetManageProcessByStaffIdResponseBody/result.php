<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vworkflow_1_0\Models\GetManageProcessByStaffIdResponseBody;

use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @description 关联考勤类型，取值。
     *
     * 2：请假
     * @var int
     */
    public $attendanceType;

    /**
     * @description 模版名称。
     *
     * @var string
     */
    public $flowTitle;

    /**
     * @description 修改时间。
     *
     * @var string
     */
    public $gmtModified;

    /**
     * @description 模板图标名。
     *
     * @var string
     */
    public $iconName;

    /**
     * @description 图标URL地址。
     *
     * @var string
     */
    public $iconUrl;

    /**
     * @description 是否新模版。
     *
     * @var bool
     */
    public $newProcess;

    /**
     * @description 模版code。
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
