<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryUserInfoResponseBody\content;

use AlibabaCloud\Tea\Model;

class userProb extends Model
{
    /**
     * @description 标签类型
     *
     * @var string
     */
    public $bizType;

    /**
     * @description 分类
     *
     * @var string
     */
    public $category;

    /**
     * @description 标签Code
     *
     * @var string
     */
    public $code;

    /**
     * @description 展示名称
     *
     * @var string
     */
    public $displayName;
    protected $_name = [
        'bizType'     => 'bizType',
        'category'    => 'category',
        'code'        => 'code',
        'displayName' => 'displayName',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->bizType) {
            $res['bizType'] = $this->bizType;
        }
        if (null !== $this->category) {
            $res['category'] = $this->category;
        }
        if (null !== $this->code) {
            $res['code'] = $this->code;
        }
        if (null !== $this->displayName) {
            $res['displayName'] = $this->displayName;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return userProb
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['bizType'])) {
            $model->bizType = $map['bizType'];
        }
        if (isset($map['category'])) {
            $model->category = $map['category'];
        }
        if (isset($map['code'])) {
            $model->code = $map['code'];
        }
        if (isset($map['displayName'])) {
            $model->displayName = $map['displayName'];
        }

        return $model;
    }
}
