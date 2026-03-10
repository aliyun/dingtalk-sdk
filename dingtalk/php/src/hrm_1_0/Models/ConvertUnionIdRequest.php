<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models;

use AlibabaCloud\Tea\Model;

class ConvertUnionIdRequest extends Model
{
    /**
     * @var string[]
     */
    public $unionIdList;

    /**
     * @var string[]
     */
    public $userIdList;
    protected $_name = [
        'unionIdList' => 'unionIdList',
        'userIdList' => 'userIdList',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->unionIdList) {
            $res['unionIdList'] = $this->unionIdList;
        }
        if (null !== $this->userIdList) {
            $res['userIdList'] = $this->userIdList;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ConvertUnionIdRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['unionIdList'])) {
            if (!empty($map['unionIdList'])) {
                $model->unionIdList = $map['unionIdList'];
            }
        }
        if (isset($map['userIdList'])) {
            if (!empty($map['userIdList'])) {
                $model->userIdList = $map['userIdList'];
            }
        }

        return $model;
    }
}
