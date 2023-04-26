<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\SearchProjectCustomfieldResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\SearchProjectCustomfieldResponseBody\result\advancedCustomfield;
use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\SearchProjectCustomfieldResponseBody\result\choices;
use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @var advancedCustomfield
     */
    public $advancedCustomfield;

    /**
     * @example 63a5301e420637003f5dxxxx
     *
     * @var string
     */
    public $boundToObjectId;

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
     * @example 63a5301e420637003f5dxxxx
     *
     * @var string
     */
    public $customfiledId;

    /**
     * @example 名字1
     *
     * @var string
     */
    public $name;

    /**
     * @example 63a5301e420637003f5dxxxx
     *
     * @var string
     */
    public $originalId;

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
        'boundToObjectId'     => 'boundToObjectId',
        'choices'             => 'choices',
        'created'             => 'created',
        'creatorId'           => 'creatorId',
        'customfiledId'       => 'customfiledId',
        'name'                => 'name',
        'originalId'          => 'originalId',
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
        if (null !== $this->boundToObjectId) {
            $res['boundToObjectId'] = $this->boundToObjectId;
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
        if (null !== $this->customfiledId) {
            $res['customfiledId'] = $this->customfiledId;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->originalId) {
            $res['originalId'] = $this->originalId;
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
        if (isset($map['boundToObjectId'])) {
            $model->boundToObjectId = $map['boundToObjectId'];
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
        if (isset($map['customfiledId'])) {
            $model->customfiledId = $map['customfiledId'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['originalId'])) {
            $model->originalId = $map['originalId'];
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
