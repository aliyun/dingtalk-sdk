<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vapaas_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vapaas_1_0\Models\BatchCreateTemplateResponseBody\createResultList;
use AlibabaCloud\Tea\Model;

class BatchCreateTemplateResponseBody extends Model
{
    /**
     * @var createResultList[]
     */
    public $createResultList;
    protected $_name = [
        'createResultList' => 'createResultList',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->createResultList) {
            $res['createResultList'] = [];
            if (null !== $this->createResultList && \is_array($this->createResultList)) {
                $n = 0;
                foreach ($this->createResultList as $item) {
                    $res['createResultList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return BatchCreateTemplateResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['createResultList'])) {
            if (!empty($map['createResultList'])) {
                $model->createResultList = [];
                $n                       = 0;
                foreach ($map['createResultList'] as $item) {
                    $model->createResultList[$n++] = null !== $item ? createResultList::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
