<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models\AddFolderRequest;

use AlibabaCloud\SDK\Dingtalk\Vstorage_1_0\Models\AddFolderRequest\option\appProperties;
use AlibabaCloud\Tea\Model;

class option extends Model
{
    /**
     * @description 文件夹在应用上的属性, 一个应用最多只能设置3个属性
     * 3
     * @var appProperties[]
     */
    public $appProperties;

    /**
     * @description 文件夹名称冲突策略
     * AUTO_RENAME
     * @var string
     */
    public $conflictStrategy;
    protected $_name = [
        'appProperties'    => 'appProperties',
        'conflictStrategy' => 'conflictStrategy',
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

        return $model;
    }
}
