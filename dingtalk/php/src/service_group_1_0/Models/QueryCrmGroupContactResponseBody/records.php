<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vservice_group_1_0\Models\QueryCrmGroupContactResponseBody;

use AlibabaCloud\Tea\Model;

class records extends Model
{
    /**
     * @example {} ,具体字段取决于客户管理-字段管理-联系人字段设置
     *
     * @var string
     */
    public $contactData;

    /**
     * @example ahghgg
     *
     * @var string
     */
    public $memberUnionId;

    /**
     * @example 张三
     *
     * @var string
     */
    public $nickName;

    /**
     * @example 88888
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'contactData' => 'contactData',
        'memberUnionId' => 'memberUnionId',
        'nickName' => 'nickName',
        'userId' => 'userId',
    ];

    public function validate() {}

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
