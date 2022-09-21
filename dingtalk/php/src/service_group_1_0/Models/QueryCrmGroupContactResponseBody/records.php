<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\QueryCrmGroupContactResponseBody;

use AlibabaCloud\Tea\Model;

class records extends Model
{
    /**
     * @description 联系人画像数据
     *
     * @var string
     */
    public $contactData;

    /**
     * @description 成员unionId
     *
     * @var string
     */
    public $memberUnionId;

    /**
     * @description 成员昵称
     *
     * @var string
     */
    public $nickName;

    /**
     * @description 成员ID
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'contactData'   => 'contactData',
        'memberUnionId' => 'memberUnionId',
        'nickName'      => 'nickName',
        'userId'        => 'userId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->contactData) {
            $res['contactData'] = $this->contactData;
        }
        if (null !== $this->memberUnionId) {
            $res['memberUnionId'] = $this->memberUnionId;
        }
        if (null !== $this->nickName) {
            $res['nickName'] = $this->nickName;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return records
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['contactData'])) {
            $model->contactData = $map['contactData'];
        }
        if (isset($map['memberUnionId'])) {
            $model->memberUnionId = $map['memberUnionId'];
        }
        if (isset($map['nickName'])) {
            $model->nickName = $map['nickName'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
