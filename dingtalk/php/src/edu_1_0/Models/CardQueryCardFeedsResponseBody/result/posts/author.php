<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vedu_1_0\Models\CardQueryCardFeedsResponseBody\result\posts;

use AlibabaCloud\Tea\Model;

class author extends Model
{
    /**
     * @example 博澜爸爸
     *
     * @var string
     */
    public $showName;

    /**
     * @example 234234234
     *
     * @var string
     */
    public $userId;

    /**
     * @example guardian
     *
     * @var string
     */
    public $userRole;
    protected $_name = [
        'showName' => 'showName',
        'userId' => 'userId',
        'userRole' => 'userRole',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->showName) {
            $res['showName'] = $this->showName;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }
        if (null !== $this->userRole) {
            $res['userRole'] = $this->userRole;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return author
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['showName'])) {
            $model->showName = $map['showName'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }
        if (isset($map['userRole'])) {
            $model->userRole = $map['userRole'];
        }

        return $model;
    }
}
