<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vindustry_1_0\Models;

use AlibabaCloud\Tea\Model;

class BusinessMatchRequest extends Model
{
    /**
     * @var string
     */
    public $businessInfo;

    /**
     * @var string
     */
    public $corpName;

    /**
     * @var string
     */
    public $userId;
    protected $_name = [
        'businessInfo' => 'businessInfo',
        'corpName'     => 'corpName',
        'userId'       => 'userId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->businessInfo) {
            $res['businessInfo'] = $this->businessInfo;
        }
        if (null !== $this->corpName) {
            $res['corpName'] = $this->corpName;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return BusinessMatchRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['businessInfo'])) {
            $model->businessInfo = $map['businessInfo'];
        }
        if (isset($map['corpName'])) {
            $model->corpName = $map['corpName'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
