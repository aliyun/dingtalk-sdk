<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vassistant_1_0\Models\GetKnowledgeListResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vassistant_1_0\Models\GetKnowledgeListResponseBody\result\knowledgeList;
use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @var knowledgeList[]
     */
    public $knowledgeList;
    protected $_name = [
        'knowledgeList' => 'knowledgeList',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->knowledgeList) {
            $res['knowledgeList'] = [];
            if (null !== $this->knowledgeList && \is_array($this->knowledgeList)) {
                $n = 0;
                foreach ($this->knowledgeList as $item) {
                    $res['knowledgeList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
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
        if (isset($map['knowledgeList'])) {
            if (!empty($map['knowledgeList'])) {
                $model->knowledgeList = [];
                $n                    = 0;
                foreach ($map['knowledgeList'] as $item) {
                    $model->knowledgeList[$n++] = null !== $item ? knowledgeList::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
