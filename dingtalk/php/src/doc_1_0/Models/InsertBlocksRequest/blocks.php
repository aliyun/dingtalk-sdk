<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\InsertBlocksRequest;

use AlibabaCloud\SDK\Dingtalk\Vdoc_1_0\Models\InsertBlocksRequest\blocks\paragraph;
use AlibabaCloud\Tea\Model;

class blocks extends Model
{
    /**
     * @description 元素类型标识
     *
     * @var string
     */
    public $blockType;

    /**
     * @description 段落元素
     *
     * @var paragraph
     */
    public $paragraph;
    protected $_name = [
        'blockType' => 'blockType',
        'paragraph' => 'paragraph',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->blockType) {
            $res['blockType'] = $this->blockType;
        }
        if (null !== $this->paragraph) {
            $res['paragraph'] = null !== $this->paragraph ? $this->paragraph->toMap() : null;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return blocks
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['blockType'])) {
            $model->blockType = $map['blockType'];
        }
        if (isset($map['paragraph'])) {
            $model->paragraph = paragraph::fromMap($map['paragraph']);
        }

        return $model;
    }
}
