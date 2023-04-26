<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryUserProbCodeDictionaryResponseBody;

use AlibabaCloud\Tea\Model;

class content extends Model
{
    /**
     * @example 1
     *
     * @var string
     */
    public $category;

    /**
     * @example 1
     *
     * @var string
     */
    public $code;

    /**
     * @example 主任医师
     *
     * @var string
     */
    public $displayName;
    protected $_name = [
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

        return $model;
    }
}
