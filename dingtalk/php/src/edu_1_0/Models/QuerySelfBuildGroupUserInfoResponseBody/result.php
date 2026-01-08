<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QuerySelfBuildGroupUserInfoResponseBody;

use AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\QuerySelfBuildGroupUserInfoResponseBody\result\userList;
use AlibabaCloud\Tea\Model;

class result extends Model
{
    /**
     * @var int
     */
    public $classId;

    /**
     * @var string
     */
    public $corpId;

    /**
     * @var string
     */
    public $requestId;

    /**
     * @var userList[]
     */
    public $userList;
    protected $_name = [
        'classId' => 'classId',
        'corpId' => 'corpId',
        'requestId' => 'requestId',
        'userList' => 'userList',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->classId) {
            $res['classId'] = $this->classId;
        }
        if (null !== $this->corpId) {
            $res['corpId'] = $this->corpId;
        }
        if (null !== $this->requestId) {
            $res['requestId'] = $this->requestId;
        }
        if (null !== $this->userList) {
            $res['userList'] = [];
            if (null !== $this->userList && \is_array($this->userList)) {
                $n = 0;
                foreach ($this->userList as $item) {
                    $res['userList'][$n++] = null !== $item ? $item->toMap() : $item;
                }
            }
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return result
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['classId'])) {
            $model->classId = $map['classId'];
        }
        if (isset($map['corpId'])) {
            $model->corpId = $map['corpId'];
        }
        if (isset($map['requestId'])) {
            $model->requestId = $map['requestId'];
        }
        if (isset($map['userList'])) {
            if (!empty($map['userList'])) {
                $model->userList = [];
                $n = 0;
                foreach ($map['userList'] as $item) {
                    $model->userList[$n++] = null !== $item ? userList::fromMap($item) : $item;
                }
            }
        }

        return $model;
    }
}
