<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryJobCodeDictionaryResponseBody;

use AlibabaCloud\Tea\Model;

class content extends Model
{
    /**
     * @description 分类
     *
     * @var string
     */
    public $category;

    /**
     * @description 固定字段标识
     *
     * @var string
     */
    public $code;

    /**
     * @description 展示名字
     *
     * @var string
     */
    public $displayName;

    /**
     * @description 1:医师,0:非医师,2:待补充
     *
     * @var string
     */
    public $doctorType;
    protected $_name = [
        'category'    => 'category',
        'code'        => 'code',
        'displayName' => 'displayName',
        'doctorType'  => 'doctorType',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->category) {
            $res['category'] = $this->category;
        }
        if (null !== $this->code) {
            $res['code'] = $this->code;
        }
        if (null !== $this->displayName) {
            $res['displayName'] = $this->displayName;
        }
        if (null !== $this->doctorType) {
            $res['doctorType'] = $this->doctorType;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return content
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['category'])) {
            $model->category = $map['category'];
        }
        if (isset($map['code'])) {
            $model->code = $map['code'];
        }
        if (isset($map['displayName'])) {
            $model->displayName = $map['displayName'];
        }
        if (isset($map['doctorType'])) {
            $model->doctorType = $map['doctorType'];
        }

        return $model;
    }
}
