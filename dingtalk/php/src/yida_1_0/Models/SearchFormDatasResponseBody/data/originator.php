<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\SearchFormDatasResponseBody\data;

use AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models\SearchFormDatasResponseBody\data\originator\userName;
use AlibabaCloud\Tea\Model;

class originator extends Model
{
    /**
     * @description 部门名称
     *
     * @var string
     */
    public $departmentName;

    /**
     * @description 邮箱
     *
     * @var string
     */
    public $email;

    /**
     * @description 用户工号
     *
     * @var string
     */
    public $userId;

    /**
     * @description 用户名
     *
     * @var userName
     */
    public $userName;
    protected $_name = [
        'departmentName' => 'departmentName',
        'email'          => 'email',
        'userId'         => 'userId',
        'userName'       => 'userName',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->departmentName) {
            $res['departmentName'] = $this->departmentName;
        }
        if (null !== $this->email) {
            $res['email'] = $this->email;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }
        if (null !== $this->userName) {
            $res['userName'] = null !== $this->userName ? $this->userName->toMap() : null;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return originator
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['departmentName'])) {
            $model->departmentName = $map['departmentName'];
        }
        if (isset($map['email'])) {
            $model->email = $map['email'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }
        if (isset($map['userName'])) {
            $model->userName = userName::fromMap($map['userName']);
        }

        return $model;
    }
}
