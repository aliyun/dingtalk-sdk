<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vlive_1_0\Models;

use AlibabaCloud\Tea\Model;

class UpdateLiveFeedResponseBody extends Model
{
    /**
     * @description 是否修改成功
     *
     * @var bool
     */
    public $hasUpdate;
    protected $_name = [
        'hasUpdate' => 'hasUpdate',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->hasUpdate) {
            $res['hasUpdate'] = $this->hasUpdate;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return UpdateLiveFeedResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['hasUpdate'])) {
            $model->hasUpdate = $map['hasUpdate'];
        }

        return $model;
    }
}
