<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vapaas_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vapaas_1_0\Models\BatchUpdateTemplateResponseBody\updateResultList;
use AlibabaCloud\Tea\Model;

class BatchUpdateTemplateResponseBody extends Model
{
    /**
     * @var updateResultList[]
     */
    public $updateResultList;
    protected $_name = [
        'updateResultList' => 'updateResultList',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->updateResultList) {
            $res['updateResultList'] = [];
            if (null !== $this->updateResultList && \is_array($this->updateResultList)) {
                $n = 0;
                foreach ($this->updateResultList as $item) {
                    $res['updateResultList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return BatchUpdateTemplateResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['updateResultList'])) {
            if (!empty($map['updateResultList'])) {
                $model->updateResultList = [];
                $n                       = 0;
                foreach ($map['updateResultList'] as $item) {
                    $model->updateResultList[$n++] = null !== $item ? updateResultList::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
