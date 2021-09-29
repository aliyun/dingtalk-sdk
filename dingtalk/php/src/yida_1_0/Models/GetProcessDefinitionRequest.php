<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetProcessDefinitionRequest extends Model
{
    /**
     * @var string
     */
    public $corpId;

    /**
     * @var string
     */
    public $groupId;

    /**
     * @var string
     */
    public $appType;

    /**
     * @var string
     */
    public $orderNumber;

    /**
     * @var string
     */
    public $systemType;

    /**
     * @var string
     */
    public $systemToken;

    /**
     * @var string
     */
    public $nameSpace;

    /**
     * @var string
     */
    public $language;

    /**
     * @var string
     */
    public $userId;
    protected $_name = [
        'corpId'      => 'corpId',
        'groupId'     => 'groupId',
        'appType'     => 'appType',
        'orderNumber' => 'orderNumber',
        'systemType'  => 'systemType',
        'systemToken' => 'systemToken',
        'nameSpace'   => 'nameSpace',
        'language'    => 'language',
        'userId'      => 'userId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->corpId) {
            $res['corpId'] = $this->corpId;
        }
        if (null !== $this->groupId) {
            $res['groupId'] = $this->groupId;
        }
        if (null !== $this->appType) {
            $res['appType'] = $this->appType;
        }
        if (null !== $this->orderNumber) {
            $res['orderNumber'] = $this->orderNumber;
        }
        if (null !== $this->systemType) {
            $res['systemType'] = $this->systemType;
        }
        if (null !== $this->systemToken) {
            $res['systemToken'] = $this->systemToken;
        }
        if (null !== $this->nameSpace) {
            $res['nameSpace'] = $this->nameSpace;
        }
        if (null !== $this->language) {
            $res['language'] = $this->language;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return GetProcessDefinitionRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['corpId'])) {
            $model->corpId = $map['corpId'];
        }
        if (isset($map['groupId'])) {
            $model->groupId = $map['groupId'];
        }
        if (isset($map['appType'])) {
            $model->appType = $map['appType'];
        }
        if (isset($map['orderNumber'])) {
            $model->orderNumber = $map['orderNumber'];
        }
        if (isset($map['systemType'])) {
            $model->systemType = $map['systemType'];
        }
        if (isset($map['systemToken'])) {
            $model->systemToken = $map['systemToken'];
        }
        if (isset($map['nameSpace'])) {
            $model->nameSpace = $map['nameSpace'];
        }
        if (isset($map['language'])) {
            $model->language = $map['language'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
