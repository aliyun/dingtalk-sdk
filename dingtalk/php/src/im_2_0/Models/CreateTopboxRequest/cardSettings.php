<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vim_2_0\Models\CreateTopboxRequest;

use AlibabaCloud\Tea\Model;

class cardSettings extends Model
{
    /**
     * @description 是否开启卡片纯拉模式。
     *
     * @var bool
     */
    public $pullStrategy;
    protected $_name = [
        'pullStrategy' => 'pullStrategy',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->pullStrategy) {
            $res['pullStrategy'] = $this->pullStrategy;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return cardSettings
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['pullStrategy'])) {
            $model->pullStrategy = $map['pullStrategy'];
        }

        return $model;
    }
}
