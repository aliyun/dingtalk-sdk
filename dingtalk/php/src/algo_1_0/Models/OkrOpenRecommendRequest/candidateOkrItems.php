<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Valgo_1_0\Models\OkrOpenRecommendRequest;

use AlibabaCloud\SDK\Dingtalk\Valgo_1_0\Models\OkrOpenRecommendRequest\candidateOkrItems\okrInfos;
use AlibabaCloud\Tea\Model;

class candidateOkrItems extends Model
{
    /**
     * @var string
     */
    public $userId;

    /**
     * @var okrInfos[]
     */
    public $okrInfos;

    /**
     * @var string
     */
    public $relation;
    protected $_name = [
        'userId'   => 'userId',
        'okrInfos' => 'okrInfos',
        'relation' => 'relation',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }
        if (null !== $this->okrInfos) {
            $res['okrInfos'] = [];
            if (null !== $this->okrInfos && \is_array($this->okrInfos)) {
                $n = 0;
                foreach ($this->okrInfos as $item) {
                    $res['okrInfos'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->relation) {
            $res['relation'] = $this->relation;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return candidateOkrItems
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }
        if (isset($map['okrInfos'])) {
            if (!empty($map['okrInfos'])) {
                $model->okrInfos = [];
                $n               = 0;
                foreach ($map['okrInfos'] as $item) {
                    $model->okrInfos[$n++] = null !== $item ? okrInfos::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['relation'])) {
            $model->relation = $map['relation'];
        }

        return $model;
    }
}