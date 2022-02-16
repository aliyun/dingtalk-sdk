<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vapaas_1_0\Models\BatchUpdateTemplateResponseBody;

use AlibabaCloud\Tea\Model;

class updateResultList extends Model
{
    /**
     * @var string
     */
    public $templateKey;

    /**
     * @var string
     */
    public $value;
    protected $_name = [
        'templateKey' => 'templateKey',
        'value'       => 'value',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->templateKey) {
            $res['templateKey'] = $this->templateKey;
        }
        if (null !== $this->value) {
            $res['value'] = $this->value;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return updateResultList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['templateKey'])) {
            $model->templateKey = $map['templateKey'];
        }
        if (isset($map['value'])) {
            $model->value = $map['value'];
        }

        return $model;
    }
}
