<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vapaas_1_0\Models;

use AlibabaCloud\Tea\Model;

class BatchQueryByTemplateKeyRequest extends Model
{
    /**
     * @var string[]
     */
    public $templateKeys;

    /**
     * @var string
     */
    public $dingSuiteKey;
    protected $_name = [
        'templateKeys' => 'templateKeys',
        'dingSuiteKey' => 'dingSuiteKey',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->templateKeys) {
            $res['templateKeys'] = $this->templateKeys;
        }
        if (null !== $this->dingSuiteKey) {
            $res['dingSuiteKey'] = $this->dingSuiteKey;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return BatchQueryByTemplateKeyRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['templateKeys'])) {
            if (!empty($map['templateKeys'])) {
                $model->templateKeys = $map['templateKeys'];
            }
        }
        if (isset($map['dingSuiteKey'])) {
            $model->dingSuiteKey = $map['dingSuiteKey'];
        }

        return $model;
    }
}
