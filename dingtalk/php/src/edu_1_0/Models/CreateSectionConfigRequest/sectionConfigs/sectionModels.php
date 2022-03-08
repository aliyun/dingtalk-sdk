<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CreateSectionConfigRequest\sectionConfigs;

use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CreateSectionConfigRequest\sectionConfigs\sectionModels\sectionEndTime;
use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CreateSectionConfigRequest\sectionConfigs\sectionModels\sectionStartTime;
use AlibabaCloud\Tea\Model;

class sectionModels extends Model
{
    /**
     * @description 结束时间
     *
     * @var sectionEndTime
     */
    public $sectionEndTime;

    /**
     * @description 第几节。
     *
     * @var int
     */
    public $sectionIndex;

    /**
     * @description 节次名称
     *
     * @var string
     */
    public $sectionName;

    /**
     * @description 开始时间
     *
     * @var sectionStartTime
     */
    public $sectionStartTime;

    /**
     * @description 节次类型枚举：COURSE/REST
     *
     * @var string
     */
    public $sectionType;
    protected $_name = [
        'sectionEndTime'   => 'sectionEndTime',
        'sectionIndex'     => 'sectionIndex',
        'sectionName'      => 'sectionName',
        'sectionStartTime' => 'sectionStartTime',
        'sectionType'      => 'sectionType',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->sectionEndTime) {
            $res['sectionEndTime'] = null !== $this->sectionEndTime ? $this->sectionEndTime->toMap() : null;
        }
        if (null !== $this->sectionIndex) {
            $res['sectionIndex'] = $this->sectionIndex;
        }
        if (null !== $this->sectionName) {
            $res['sectionName'] = $this->sectionName;
        }
        if (null !== $this->sectionStartTime) {
            $res['sectionStartTime'] = null !== $this->sectionStartTime ? $this->sectionStartTime->toMap() : null;
        }
        if (null !== $this->sectionType) {
            $res['sectionType'] = $this->sectionType;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return sectionModels
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['sectionEndTime'])) {
            $model->sectionEndTime = sectionEndTime::fromMap($map['sectionEndTime']);
        }
        if (isset($map['sectionIndex'])) {
            $model->sectionIndex = $map['sectionIndex'];
        }
        if (isset($map['sectionName'])) {
            $model->sectionName = $map['sectionName'];
        }
        if (isset($map['sectionStartTime'])) {
            $model->sectionStartTime = sectionStartTime::fromMap($map['sectionStartTime']);
        }
        if (isset($map['sectionType'])) {
            $model->sectionType = $map['sectionType'];
        }

        return $model;
    }
}
