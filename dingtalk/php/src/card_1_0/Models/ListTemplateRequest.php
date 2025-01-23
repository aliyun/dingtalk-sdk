<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcard_1_0\Models;

use AlibabaCloud\Tea\Model;

class ListTemplateRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $templateIds;
    protected $_name = [
        'templateIds' => 'templateIds',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->templateIds) {
            $res['templateIds'] = $this->templateIds;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ListTemplateRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['templateIds'])) {
            $model->templateIds = $map['templateIds'];
        }

        return $model;
    }
}
