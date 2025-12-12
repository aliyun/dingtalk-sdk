<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\AiTrainingRecordResponseBody\trainingList;
use AlibabaCloud\Tea\Model;

class AiTrainingRecordResponseBody extends Model
{
    /**
     * @var int
     */
    public $direction;

    /**
     * @var bool
     */
    public $hasMore;

    /**
     * @var int
     */
    public $lastId;

    /**
     * @var trainingList[]
     */
    public $trainingList;
    protected $_name = [
        'direction' => 'direction',
        'hasMore' => 'hasMore',
        'lastId' => 'lastId',
        'trainingList' => 'trainingList',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->direction) {
            $res['direction'] = $this->direction;
        }
        if (null !== $this->hasMore) {
            $res['hasMore'] = $this->hasMore;
        }
        if (null !== $this->lastId) {
            $res['lastId'] = $this->lastId;
        }
        if (null !== $this->trainingList) {
            $res['trainingList'] = [];
            if (null !== $this->trainingList && \is_array($this->trainingList)) {
                $n = 0;
                foreach ($this->trainingList as $item) {
                    $res['trainingList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return AiTrainingRecordResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['direction'])) {
            $model->direction = $map['direction'];
        }
        if (isset($map['hasMore'])) {
            $model->hasMore = $map['hasMore'];
        }
        if (isset($map['lastId'])) {
            $model->lastId = $map['lastId'];
        }
        if (isset($map['trainingList'])) {
            if (!empty($map['trainingList'])) {
                $model->trainingList = [];
                $n = 0;
                foreach ($map['trainingList'] as $item) {
                    $model->trainingList[$n++] = null !== $item ? trainingList::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
