<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vapaas_1_0\Models;

use AlibabaCloud\SDK\Dingtalk\Vapaas_1_0\Models\BatchCreateTemplateRequest\templateList;
use AlibabaCloud\Tea\Model;

class BatchCreateTemplateRequest extends Model
{
    /**
     * @var templateList[]
     */
    public $templateList;

    /**
     * @var string
     */
    public $dingSuiteKey;
    protected $_name = [
        'templateList' => 'templateList',
        'dingSuiteKey' => 'dingSuiteKey',
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
        if (null !== $this->dingSuiteKey) {
            $res['dingSuiteKey'] = $this->dingSuiteKey;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return BatchCreateTemplateRequest
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
        if (isset($map['dingSuiteKey'])) {
            $model->dingSuiteKey = $map['dingSuiteKey'];
        }

        return $model;
    }
}
