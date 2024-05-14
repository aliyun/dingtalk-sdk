<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vswform_1_0\Models\ListFormSchemasByCreatorResponseBody\result\list_;

use AlibabaCloud\Tea\Model;

class setting extends Model
{
    /**
     * @example 0
     *
     * @var int
     */
    public $bizType;

    /**
     * @description Use the UTC time format: yyyy-MM-ddTHH:mmZ
     *
     * @example 2022-07-27T18:53Z
     *
     * @var string
     */
    public $createTime;

    /**
     * @description Use the UTC time format: yyyy-MM-ddTHH:mmZ
     *
     * @example 2022-07-27T18:53Z
     *
     * @var string
     */
    public $endTime;

    /**
     * @example 0
     *
     * @var int
     */
    public $formType;

    /**
     * @var int[]
     */
    public $loopDays;

    /**
     * @example 18:00
     *
     * @var string
     */
    public $loopTime;

    /**
     * @example true
     *
     * @var bool
     */
    public $stop;
    protected $_name = [
        'bizType'    => 'bizType',
        'createTime' => 'createTime',
        'endTime'    => 'endTime',
        'formType'   => 'formType',
        'loopDays'   => 'loopDays',
        'loopTime'   => 'loopTime',
        'stop'       => 'stop',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->bizType) {
            $res['bizType'] = $this->bizType;
        }
        if (null !== $this->createTime) {
            $res['createTime'] = $this->createTime;
        }
        if (null !== $this->endTime) {
            $res['endTime'] = $this->endTime;
        }
        if (null !== $this->formType) {
            $res['formType'] = $this->formType;
        }
        if (null !== $this->loopDays) {
            $res['loopDays'] = $this->loopDays;
        }
        if (null !== $this->loopTime) {
            $res['loopTime'] = $this->loopTime;
        }
        if (null !== $this->stop) {
            $res['stop'] = $this->stop;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return setting
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['bizType'])) {
            $model->bizType = $map['bizType'];
        }
        if (isset($map['createTime'])) {
            $model->createTime = $map['createTime'];
        }
        if (isset($map['endTime'])) {
            $model->endTime = $map['endTime'];
        }
        if (isset($map['formType'])) {
            $model->formType = $map['formType'];
        }
        if (isset($map['loopDays'])) {
            if (!empty($map['loopDays'])) {
                $model->loopDays = $map['loopDays'];
            }
        }
        if (isset($map['loopTime'])) {
            $model->loopTime = $map['loopTime'];
        }
        if (isset($map['stop'])) {
            $model->stop = $map['stop'];
        }

        return $model;
    }
}
