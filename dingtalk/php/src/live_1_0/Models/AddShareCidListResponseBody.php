<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vlive_1_0\Models;

use AlibabaCloud\Tea\Model;

class AddShareCidListResponseBody extends Model
{
    /**
     * @description 是否联播成功
     *
     * @var bool
     */
    public $hasShareSuccess;

    /**
     * @description 本次请求成功联播的群列表
     *
     * @var string[]
     */
    public $shareSuccessGroupList;
    protected $_name = [
        'hasShareSuccess'       => 'hasShareSuccess',
        'shareSuccessGroupList' => 'shareSuccessGroupList',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->hasShareSuccess) {
            $res['hasShareSuccess'] = $this->hasShareSuccess;
        }
        if (null !== $this->shareSuccessGroupList) {
            $res['shareSuccessGroupList'] = $this->shareSuccessGroupList;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return AddShareCidListResponseBody
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['hasShareSuccess'])) {
            $model->hasShareSuccess = $map['hasShareSuccess'];
        }
        if (isset($map['shareSuccessGroupList'])) {
            if (!empty($map['shareSuccessGroupList'])) {
                $model->shareSuccessGroupList = $map['shareSuccessGroupList'];
            }
        }

        return $model;
    }
}
