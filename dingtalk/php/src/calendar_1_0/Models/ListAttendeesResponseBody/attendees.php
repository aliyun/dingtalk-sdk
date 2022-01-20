<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcalendar_1_0\Models\ListAttendeesResponseBody;

use AlibabaCloud\Tea\Model;

class attendees extends Model
{
    /**
     * @description 用户id
     *
     * @var string
     */
    public $id;

    /**
     * @description 用户名
     *
     * @var string
     */
    public $displayName;

    /**
     * @description 回复状态
     *
     * @var string
     */
    public $responseStatus;

    /**
     * @description 是否当前用户
     *
     * @var bool
     */
    public $self;
    protected $_name = [
        'id'             => 'id',
        'displayName'    => 'displayName',
        'responseStatus' => 'responseStatus',
        'self'           => 'self',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->id) {
            $res['id'] = $this->id;
        }
        if (null !== $this->displayName) {
            $res['displayName'] = $this->displayName;
        }
        if (null !== $this->responseStatus) {
            $res['responseStatus'] = $this->responseStatus;
        }
        if (null !== $this->self) {
            $res['self'] = $this->self;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return attendees
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['id'])) {
            $model->id = $map['id'];
        }
        if (isset($map['displayName'])) {
            $model->displayName = $map['displayName'];
        }
        if (isset($map['responseStatus'])) {
            $model->responseStatus = $map['responseStatus'];
        }
        if (isset($map['self'])) {
            $model->self = $map['self'];
        }

        return $model;
    }
}
