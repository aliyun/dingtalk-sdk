<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vchengfeng_1_0\Models\PageListObjectiveProgressResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vchengfeng_1_0\Models\OpenProgressDTO;
use AlibabaCloud\Tea\Model;

class content extends Model
{
    /**
     * @var int
     */
    public $count;

    /**
     * @var OpenProgressDTO[]
     */
    public $progressList;
    protected $_name = [
        'count'        => 'count',
        'progressList' => 'progressList',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->count) {
            $res['count'] = $this->count;
        }
        if (null !== $this->progressList) {
            $res['progressList'] = [];
            if (null !== $this->progressList && \is_array($this->progressList)) {
                $n = 0;
                foreach ($this->progressList as $item) {
                    $res['progressList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return content
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['count'])) {
            $model->count = $map['count'];
        }
        if (isset($map['progressList'])) {
            if (!empty($map['progressList'])) {
                $model->progressList = [];
                $n                   = 0;
                foreach ($map['progressList'] as $item) {
                    $model->progressList[$n++] = null !== $item ? OpenProgressDTO::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
