<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vhrbrain_1_0\Models\HrbrainLabelTaskMetaResponseBody;

use AlibabaCloud\Tea\Model;

class content extends Model
{
    /**
     * @var string
     */
    public $code;

    /**
     * @var string
     */
    public $description;

    /**
     * @var string
     */
    public $isSystem;

    /**
     * @var string
     */
    public $name;

    /**
     * @var mixed[]
     */
    public $tagConfig;
    protected $_name = [
        'code' => 'code',
        'description' => 'description',
        'isSystem' => 'isSystem',
        'name' => 'name',
        'tagConfig' => 'tagConfig',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->code) {
            $res['code'] = $this->code;
        }
        if (null !== $this->description) {
            $res['description'] = $this->description;
        }
        if (null !== $this->isSystem) {
            $res['isSystem'] = $this->isSystem;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->tagConfig) {
            $res['tagConfig'] = $this->tagConfig;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return content
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['code'])) {
            $model->code = $map['code'];
        }
        if (isset($map['description'])) {
            $model->description = $map['description'];
        }
        if (isset($map['isSystem'])) {
            $model->isSystem = $map['isSystem'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['tagConfig'])) {
            $model->tagConfig = $map['tagConfig'];
        }

        return $model;
    }
}
