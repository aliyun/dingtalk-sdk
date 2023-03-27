<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\SearchProjectCustomfieldResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\SearchProjectCustomfieldResponseBody\result\advancedCustomfield;
use AlibabaCloud\SDK\Dingtalk\Vproject_1_0\Models\SearchProjectCustomfieldResponseBody\result\choices;
use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @description 高级自定义字段。
     *
     * @var advancedCustomfield
     */
    public $advancedCustomfield;

    /**
     * @description 绑定的对象Id，此接口为项目ID。
     *
     * @var string
     */
    public $boundToObjectId;

    /**
     * @description 如果是单选或多选字段，这里是可选项的值
     *
     * @var choices[]
     */
    public $choices;

    /**
     * @description 创建时间。
     *
     * @var string
     */
    public $created;

    /**
     * @description 创建人ID。
     *
     * @var string
     */
    public $creatorId;

    /**
     * @description 自定义字段ID。
     *
     * @var string
     */
    public $customfiledId;

    /**
     * @description 字段名称。
     *
     * @var string
     */
    public $name;

    /**
     * @description 如果是企业字段，该字段表达绑定的企业字段ID。
     *
     * @var string
     */
    public $originalId;

    /**
     * @description 用户自定义数据载体，json格式类型任意数据。
     *
     * @var mixed[]
     */
    public $payload;

    /**
     * @description 字段类型。 'number', // 数字 'date', // 日期 'text', // 文本 'work', 'multipleChoice', // 多选 'dropDown', // 下拉, 'lookup', 'commongroup', 'cascading', // 层级字段 'rtf', // 多行文本/富文本 字段 'lookup2' // 新高级字段
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
