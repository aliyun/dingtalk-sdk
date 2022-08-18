<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models\CommitFileRequest;

use AlibabaCloud\Tea\Model;

class option extends Model
{
    /**
     * @description 文件名称冲突策略
     * AUTO_RENAME
     * @var string
     */
    public $conflictStrategy;

    /**
     * @description 默认文件大小, 单位:Byte
     * 如果此字段不为空，企业存储系统会校验文件实际大小是否和此字段是否一致，不一致会报错
     * @var int
     */
    public $size;
    protected $_name = [
        'conflictStrategy' => 'conflictStrategy',
        'size'             => 'size',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->conflictStrategy) {
            $res['conflictStrategy'] = $this->conflictStrategy;
        }
        if (null !== $this->size) {
            $res['size'] = $this->size;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return option
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['conflictStrategy'])) {
            $model->conflictStrategy = $map['conflictStrategy'];
        }
        if (isset($map['size'])) {
            $model->size = $map['size'];
        }

        return $model;
    }
}
