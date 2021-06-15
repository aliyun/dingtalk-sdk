<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryDepartmentInfoResponseBody\content\residentLeader;

use AlibabaCloud\Tea\Model;

class job extends Model
{
    /**
     * @description 标签Code
     *
     * @var string
     */
    public $code;

    /**
     * @description 业务类型
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
     * @description 展示名称
     *
     * @var string
     */
    public $displayName;
    protected $_name = [
        'code'        => 'code',
        'bizType'     => 'bizType',
        'category'    => 'category',
        'displayName' => 'displayName',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->code) {
            $res['code'] = $this->code;
        }
        if (null !== $this->bizType) {
            $res['bizType'] = $this->bizType;
        }
        if (null !== $this->category) {
            $res['category'] = $this->category;
        }
        if (null !== $this->displayName) {
            $res['displayName'] = $this->displayName;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return job
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['code'])) {
            $model->code = $map['code'];
        }
        if (isset($map['bizType'])) {
            $model->bizType = $map['bizType'];
        }
        if (isset($map['category'])) {
            $model->category = $map['category'];
        }
        if (isset($map['displayName'])) {
            $model->displayName = $map['displayName'];
        }

        return $model;
    }
}
