<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models\QueryDoctorDetailsByJobNumberResponseBody\content;

use AlibabaCloud\Tea\Model;

class userProbList extends Model
{
    /**
     * @description 身份属性编码
     *
     * @var string
     */
    public $code;

    /**
     * @description 身份属性名称
     *
     * @var string
     */
    public $userPropertyName;
    protected $_name = [
        'code'             => 'code',
        'userPropertyName' => 'userPropertyName',
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
        if (null !== $this->userPropertyName) {
            $res['userPropertyName'] = $this->userPropertyName;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return userProbList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['code'])) {
            $model->code = $map['code'];
        }
        if (isset($map['userPropertyName'])) {
            $model->userPropertyName = $map['userPropertyName'];
        }

        return $model;
    }
}
