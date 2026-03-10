<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vai_search_ask_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vai_search_ask_1_0\Models\RetrievalExtendParamsValue\sourceUserParams;
use AlibabaCloud\SDK\Dingtalk\Vai_search_ask_1_0\Models\RetrievalExtendParamsValue\targetUserParams;
use AlibabaCloud\Tea\Model;

class RetrievalExtendParamsValue extends Model
{
    /**
     * @var int
     */
    public $startTime;

    /**
     * @var int
     */
    public $endTime;

    /**
     * @var string[]
     */
    public $keywords;

    /**
     * @var sourceUserParams[]
     */
    public $sourceUserParams;

    /**
     * @var targetUserParams[]
     */
    public $targetUserParams;
    protected $_name = [
        'startTime' => 'startTime',
        'endTime' => 'endTime',
        'keywords' => 'keywords',
        'sourceUserParams' => 'sourceUserParams',
        'targetUserParams' => 'targetUserParams',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->startTime) {
            $res['startTime'] = $this->startTime;
        }
        if (null !== $this->endTime) {
            $res['endTime'] = $this->endTime;
        }
        if (null !== $this->keywords) {
            $res['keywords'] = $this->keywords;
        }
        if (null !== $this->sourceUserParams) {
            $res['sourceUserParams'] = [];
            if (null !== $this->sourceUserParams && \is_array($this->sourceUserParams)) {
                $n = 0;
                foreach ($this->sourceUserParams as $item) {
                    $res['sourceUserParams'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->targetUserParams) {
            $res['targetUserParams'] = [];
            if (null !== $this->targetUserParams && \is_array($this->targetUserParams)) {
                $n = 0;
                foreach ($this->targetUserParams as $item) {
                    $res['targetUserParams'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return RetrievalExtendParamsValue
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['startTime'])) {
            $model->startTime = $map['startTime'];
        }
        if (isset($map['endTime'])) {
            $model->endTime = $map['endTime'];
        }
        if (isset($map['keywords'])) {
            if (!empty($map['keywords'])) {
                $model->keywords = $map['keywords'];
            }
        }
        if (isset($map['sourceUserParams'])) {
            if (!empty($map['sourceUserParams'])) {
                $model->sourceUserParams = [];
                $n = 0;
                foreach ($map['sourceUserParams'] as $item) {
                    $model->sourceUserParams[$n++] = null !== $item ? sourceUserParams::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['targetUserParams'])) {
            if (!empty($map['targetUserParams'])) {
                $model->targetUserParams = [];
                $n = 0;
                foreach ($map['targetUserParams'] as $item) {
                    $model->targetUserParams[$n++] = null !== $item ? targetUserParams::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
