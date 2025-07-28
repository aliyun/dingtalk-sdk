<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\GetClassWithDeletedResponseBody\result;

use AlibabaCloud\SDK\Dingtalk\Vattendance_1_0\Models\GetClassWithDeletedResponseBody\result\classSetting\restTimeList;
use AlibabaCloud\Tea\Model;

class classSetting extends Model
{
    /**
     * @example 1
     *
     * @var int
     */
    public $classSettingId;

    /**
     * @var restTimeList[]
     */
    public $restTimeList;
    protected $_name = [
        'classSettingId' => 'classSettingId',
        'restTimeList' => 'restTimeList',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->classSettingId) {
            $res['classSettingId'] = $this->classSettingId;
        }
        if (null !== $this->restTimeList) {
            $res['restTimeList'] = [];
            if (null !== $this->restTimeList && \is_array($this->restTimeList)) {
                $n = 0;
                foreach ($this->restTimeList as $item) {
                    $res['restTimeList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return classSetting
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['classSettingId'])) {
            $model->classSettingId = $map['classSettingId'];
        }
        if (isset($map['restTimeList'])) {
            if (!empty($map['restTimeList'])) {
                $model->restTimeList = [];
                $n = 0;
                foreach ($map['restTimeList'] as $item) {
                    $model->restTimeList[$n++] = null !== $item ? restTimeList::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
