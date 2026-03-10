<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vexclusive_1_0\Models;

use AlibabaCloud\Tea\Model;

class ExclusivePcAlertRequest extends Model
{
    /**
     * @description This parameter is required.
     *
     * @var string
     */
    public $imageMediaId;

    /**
     * @var string
     */
    public $openLink;

    /**
     * @description This parameter is required.
     *
     * @var string[]
     */
    public $userList;
    protected $_name = [
        'imageMediaId' => 'imageMediaId',
        'openLink' => 'openLink',
        'userList' => 'userList',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->imageMediaId) {
            $res['imageMediaId'] = $this->imageMediaId;
        }
        if (null !== $this->openLink) {
            $res['openLink'] = $this->openLink;
        }
        if (null !== $this->userList) {
            $res['userList'] = $this->userList;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return ExclusivePcAlertRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['imageMediaId'])) {
            $model->imageMediaId = $map['imageMediaId'];
        }
        if (isset($map['openLink'])) {
            $model->openLink = $map['openLink'];
        }
        if (isset($map['userList'])) {
            if (!empty($map['userList'])) {
                $model->userList = $map['userList'];
            }
        }

        return $model;
    }
}
