<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vagoal_1_0\Models;

use AlibabaCloud\Tea\Model;

class OpenAgoalOrgObjectiveListDTO extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var OpenAgoalOrgObjectiveDTO[]
     */
    public $objectiveList;

    /**
     * @description This parameter is required.
     *
     * @example 100
     *
     * @var int
     */
    public $totalCount;
    protected $_name = [
        'objectiveList' => 'objectiveList',
        'totalCount' => 'totalCount',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->objectiveList) {
            $res['objectiveList'] = [];
            if (null !== $this->objectiveList && \is_array($this->objectiveList)) {
                $n = 0;
                foreach ($this->objectiveList as $item) {
                    $res['objectiveList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->totalCount) {
            $res['totalCount'] = $this->totalCount;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return OpenAgoalOrgObjectiveListDTO
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['objectiveList'])) {
            if (!empty($map['objectiveList'])) {
                $model->objectiveList = [];
                $n = 0;
                foreach ($map['objectiveList'] as $item) {
                    $model->objectiveList[$n++] = null !== $item ? OpenAgoalOrgObjectiveDTO::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['totalCount'])) {
            $model->totalCount = $map['totalCount'];
        }

        return $model;
    }
}
