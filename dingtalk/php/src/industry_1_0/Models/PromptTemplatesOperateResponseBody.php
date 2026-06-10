<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models;

use AlibabaCloud\Tea\Model;

class PromptTemplatesOperateResponseBody extends Model
{
    /**
     * @var string
     */
    public $bizCode;

    /**
     * @var string
     */
    public $content;

    /**
     * @var string
     */
    public $description;

    /**
     * @var int
     */
    public $placeholderCount;

    /**
     * @var string
     */
    public $source;
    protected $_name = [
        'bizCode' => 'bizCode',
        'content' => 'content',
        'description' => 'description',
        'placeholderCount' => 'placeholderCount',
        'source' => 'source',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->bizCode) {
            $res['bizCode'] = $this->bizCode;
        }
        if (null !== $this->content) {
            $res['content'] = $this->content;
        }
        if (null !== $this->description) {
            $res['description'] = $this->description;
        }
        if (null !== $this->placeholderCount) {
            $res['placeholderCount'] = $this->placeholderCount;
        }
        if (null !== $this->source) {
            $res['source'] = $this->source;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return PromptTemplatesOperateResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['bizCode'])) {
            $model->bizCode = $map['bizCode'];
        }
        if (isset($map['content'])) {
            $model->content = $map['content'];
        }
        if (isset($map['description'])) {
            $model->description = $map['description'];
        }
        if (isset($map['placeholderCount'])) {
            $model->placeholderCount = $map['placeholderCount'];
        }
        if (isset($map['source'])) {
            $model->source = $map['source'];
        }

        return $model;
    }
}
