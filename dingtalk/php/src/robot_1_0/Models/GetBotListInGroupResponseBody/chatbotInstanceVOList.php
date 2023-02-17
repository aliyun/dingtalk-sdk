<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vrobot_1_0\Models\GetBotListInGroupResponseBody;

use AlibabaCloud\Tea\Model;

class chatbotInstanceVOList extends Model
{
    /**
     * @var string
     */
    public $downloadIconURL;

    /**
     * @var string
     */
    public $name;

    /**
     * @var int
     */
    public $openRobotType;

    /**
     * @var string
     */
    public $robotCode;
    protected $_name = [
        'downloadIconURL' => 'downloadIconURL',
        'name'            => 'name',
        'openRobotType'   => 'openRobotType',
        'robotCode'       => 'robotCode',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->downloadIconURL) {
            $res['downloadIconURL'] = $this->downloadIconURL;
        }
        if (null !== $this->name) {
            $res['name'] = $this->name;
        }
        if (null !== $this->openRobotType) {
            $res['openRobotType'] = $this->openRobotType;
        }
        if (null !== $this->robotCode) {
            $res['robotCode'] = $this->robotCode;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return chatbotInstanceVOList
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['downloadIconURL'])) {
            $model->downloadIconURL = $map['downloadIconURL'];
        }
        if (isset($map['name'])) {
            $model->name = $map['name'];
        }
        if (isset($map['openRobotType'])) {
            $model->openRobotType = $map['openRobotType'];
        }
        if (isset($map['robotCode'])) {
            $model->robotCode = $map['robotCode'];
        }

        return $model;
    }
}
