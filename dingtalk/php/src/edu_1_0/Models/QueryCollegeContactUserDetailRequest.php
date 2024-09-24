<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models;

use AlibabaCloud\Tea\Model;

class QueryCollegeContactUserDetailRequest extends Model
{
    /**
     * @example zh_CN
     *
     * @var string
     */
    public $language;

    /**
     * @description This parameter is required.
     *
     * @example zhangsan666
     *
     * @var string
     */
    public $userid;
    protected $_name = [
        'language' => 'language',
        'userid'   => 'userid',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->language) {
            $res['language'] = $this->language;
        }
        if (null !== $this->userid) {
            $res['userid'] = $this->userid;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return QueryCollegeContactUserDetailRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['language'])) {
            $model->language = $map['language'];
        }
        if (isset($map['userid'])) {
            $model->userid = $map['userid'];
        }

        return $model;
    }
}
