<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vassistant_1_0\Models\ListInstanceResponseBody;

use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @var string
     */
    public $description;

    /**
     * @var string
     */
    public $icon;

    /**
     * @var string
     */
    public $name;

    /**
     * @var string
     */
    public $prototypeAssistantId;

    /**
     * @var string
     */
    public $tenantAssistantId;
    protected $_name = [
        'description' => 'description',
        'icon' => 'icon',
        'name' => 'name',
        'prototypeAssistantId' => 'prototypeAssistantId',
        'tenantAssistantId' => 'tenantAssistantId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->description) {
            $res['description'] = $this->description;
        }
        if (null !== $this->icon) {
            $res['icon'] = $this->icon;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->prototypeAssistantId) {
            $res['prototypeAssistantId'] = $this->prototypeAssistantId;
        }
        if (null !== $this->tenantAssistantId) {
            $res['tenantAssistantId'] = $this->tenantAssistantId;
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
        if (isset($map['description'])) {
            $model->description = $map['description'];
        }
        if (isset($map['icon'])) {
            $model->icon = $map['icon'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['prototypeAssistantId'])) {
            $model->prototypeAssistantId = $map['prototypeAssistantId'];
        }
        if (isset($map['tenantAssistantId'])) {
            $model->tenantAssistantId = $map['tenantAssistantId'];
        }

        return $model;
    }
}
