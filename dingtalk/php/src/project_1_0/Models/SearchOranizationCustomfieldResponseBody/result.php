<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\SearchOranizationCustomfieldResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\SearchOranizationCustomfieldResponseBody\result\advancedCustomfield;
use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\SearchOranizationCustomfieldResponseBody\result\choices;
use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @var advancedCustomfield
     */
    public $advancedCustomfield;

    /**
     * @var choices[]
     */
    public $choices;

    /**
     * @example 2022-07-04T03:29:34.770Z
     *
     * @var string
     */
    public $created;

    /**
     * @example 0715153011125xxxx
     *
     * @var string
     */
    public $creatorId;

    /**
     * @example 60a2187eb72xxxxxxx
     *
     * @var string
     */
    public $customfieldsId;

    /**
     * @example 自定义字段
     *
     * @var string
     */
    public $name;

    /**
     * @example {"_appId":"5937b10b83963200444b1ff8","kanbanCardAddCustomfieldDisable":true,"locales":{"name":{"en":"Progress update time","zh":"进展更新时间"}}}
     *
     * @var mixed[]
     */
    public $payload;

    /**
     * @example number
     *
     * @var string
     */
    public $type;
    protected $_name = [
        'advancedCustomfield' => 'advancedCustomfield',
        'choices'             => 'choices',
        'created'             => 'created',
        'creatorId'           => 'creatorId',
        'customfieldsId'      => 'customfieldsId',
        'name'                => 'name',
        'payload'             => 'payload',
        'type'                => 'type',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->advancedCustomfield) {
            $res['advancedCustomfield'] = null !== $this->advancedCustomfield ? $this->advancedCustomfield->toMap() : null;
        }
        if (null !== $this->choices) {
            $res['choices'] = [];
            if (null !== $this->choices && \is_array($this->choices)) {
                $n = 0;
                foreach ($this->choices as $item) {
                    $res['choices'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
        if (null !== $this->created) {
            $res['created'] = $this->created;
        }
        if (null !== $this->creatorId) {
            $res['creatorId'] = $this->creatorId;
        }
        if (null !== $this->customfieldsId) {
            $res['customfieldsId'] = $this->customfieldsId;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->payload) {
            $res['payload'] = $this->payload;
        }
        if (null !== $this->type) {
            $res['type'] = $this->type;
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
        if (isset($map['advancedCustomfield'])) {
            $model->advancedCustomfield = advancedCustomfield::fromMap($map['advancedCustomfield']);
        }
        if (isset($map['choices'])) {
            if (!empty($map['choices'])) {
                $model->choices = [];
                $n              = 0;
                foreach ($map['choices'] as $item) {
                    $model->choices[$n++] = null !== $item ? choices::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['created'])) {
            $model->created = $map['created'];
        }
        if (isset($map['creatorId'])) {
            $model->creatorId = $map['creatorId'];
        }
        if (isset($map['customfieldsId'])) {
            $model->customfieldsId = $map['customfieldsId'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['payload'])) {
            $model->payload = $map['payload'];
        }
        if (isset($map['type'])) {
            $model->type = $map['type'];
        }

        return $model;
    }
}
