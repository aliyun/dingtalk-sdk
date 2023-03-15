<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vstorage_2_0\Models\CommitFileRequest;

use AlibabaCloud\SDK\Dingtalk\Vstorage_2_0\Models\CommitFileRequest\option\appProperties;
use AlibabaCloud\Tea\Model;

class option extends Model
{
    /**
     * @description 文件在应用上的属性, 一个应用最多只能设置3个属性
     * 3
     * @var appProperties[]
     */
    public $appProperties;

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
        'appProperties'    => 'appProperties',
        'conflictStrategy' => 'conflictStrategy',
        'size'             => 'size',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->appProperties) {
            $res['appProperties'] = [];
            if (null !== $this->appProperties && \is_array($this->appProperties)) {
                $n = 0;
                foreach ($this->appProperties as $item) {
                    $res['appProperties'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }
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
        if (isset($map['appProperties'])) {
            if (!empty($map['appProperties'])) {
                $model->appProperties = [];
                $n                    = 0;
                foreach ($map['appProperties'] as $item) {
                    $model->appProperties[$n++] = null !== $item ? appProperties::fromMap($item) : $item;
                }
            }
        }
        if (isset($map['conflictStrategy'])) {
            $model->conflictStrategy = $map['conflictStrategy'];
        }
        if (isset($map['size'])) {
            $model->size = $map['size'];
        }

        return $model;
    }
}
