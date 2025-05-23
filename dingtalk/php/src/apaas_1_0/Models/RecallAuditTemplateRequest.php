<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vapaas_1_0\Models;

use AlibabaCloud\Tea\Model;

class RecallAuditTemplateRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var string[]
     */
    public $templateKeys;
    protected $_name = [
        'templateKeys' => 'templateKeys',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->templateKeys) {
            $res['templateKeys'] = $this->templateKeys;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return RecallAuditTemplateRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['templateKeys'])) {
            if (!empty($map['templateKeys'])) {
                $model->templateKeys = $map['templateKeys'];
            }
        }

        return $model;
    }
}
