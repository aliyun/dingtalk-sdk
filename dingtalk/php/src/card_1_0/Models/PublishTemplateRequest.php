<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcard_1_0\Models;

use AlibabaCloud\Tea\Model;

class PublishTemplateRequest extends Model
{
    /**
     * @var string
     */
    public $name;

    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $templateId;

    /**
     * @var string
     */
    public $templateSource;
    protected $_name = [
        'name' => 'name',
        'templateId' => 'templateId',
        'templateSource' => 'templateSource',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->templateId) {
            $res['templateId'] = $this->templateId;
        }
        if (null !== $this->templateSource) {
            $res['templateSource'] = $this->templateSource;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return PublishTemplateRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['templateId'])) {
            $model->templateId = $map['templateId'];
        }
        if (isset($map['templateSource'])) {
            $model->templateSource = $map['templateSource'];
        }

        return $model;
    }
}
