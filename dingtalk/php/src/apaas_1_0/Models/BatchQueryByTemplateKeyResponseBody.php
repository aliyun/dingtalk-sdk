<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vapaas_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vapaas_1_0\Models\BatchQueryByTemplateKeyResponseBody\templateList;
use AlibabaCloud\Tea\Model;

class BatchQueryByTemplateKeyResponseBody extends Model
{
    /**
     * @var templateList[]
     */
    public $templateList;
    protected $_name = [
        'templateList' => 'templateList',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->templateList) {
            $res['templateList'] = [];
            if (null !== $this->templateList && \is_array($this->templateList)) {
                $n = 0;
                foreach ($this->templateList as $item) {
                    $res['templateList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return BatchQueryByTemplateKeyResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['templateList'])) {
            if (!empty($map['templateList'])) {
                $model->templateList = [];
                $n                   = 0;
                foreach ($map['templateList'] as $item) {
                    $model->templateList[$n++] = null !== $item ? templateList::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
