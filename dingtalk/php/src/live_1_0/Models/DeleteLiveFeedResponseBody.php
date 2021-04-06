<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vlive_1_0\Models;

use AlibabaCloud\Tea\Model;

class DeleteLiveFeedResponseBody extends Model
{
    /**
     * @description 是否删除成功
     *
     * @var bool
     */
    public $hasDelete;
    protected $_name = [
        'hasDelete' => 'hasDelete',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->hasDelete) {
            $res['hasDelete'] = $this->hasDelete;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return DeleteLiveFeedResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['hasDelete'])) {
            $model->hasDelete = $map['hasDelete'];
        }

        return $model;
    }
}
