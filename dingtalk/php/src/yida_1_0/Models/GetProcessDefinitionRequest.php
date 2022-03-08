<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models;

use AlibabaCloud\Tea\Model;

class GetProcessDefinitionRequest extends Model
{
    /**
     * @var string
     */
    public $appType;

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
    public $language;

    /**
     * @var string
     */
    public $nameSpace;

    /**
     * @var string
     */
    public $orderNumber;

    /**
     * @var string
     */
    public $systemToken;

    /**
     * @var string
     */
    public $systemType;

    /**
     * @var string
     */
    public $userId;
    protected $_name = [
        'appType'     => 'appType',
        'corpId'      => 'corpId',
        'groupId'     => 'groupId',
        'language'    => 'language',
        'nameSpace'   => 'nameSpace',
        'orderNumber' => 'orderNumber',
        'systemToken' => 'systemToken',
        'systemType'  => 'systemType',
        'userId'      => 'userId',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->appType) {
            $res['appType'] = $this->appType;
        }
        if (null !== $this->corpId) {
            $res['corpId'] = $this->corpId;
        }
        if (null !== $this->groupId) {
            $res['groupId'] = $this->groupId;
        }
        if (null !== $this->language) {
            $res['language'] = $this->language;
        }
        if (null !== $this->nameSpace) {
            $res['nameSpace'] = $this->nameSpace;
        }
        if (null !== $this->orderNumber) {
            $res['orderNumber'] = $this->orderNumber;
        }
        if (null !== $this->systemToken) {
            $res['systemToken'] = $this->systemToken;
        }
        if (null !== $this->systemType) {
            $res['systemType'] = $this->systemType;
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
        if (isset($map['appType'])) {
            $model->appType = $map['appType'];
        }
        if (isset($map['corpId'])) {
            $model->corpId = $map['corpId'];
        }
        if (isset($map['groupId'])) {
            $model->groupId = $map['groupId'];
        }
        if (isset($map['language'])) {
            $model->language = $map['language'];
        }
        if (isset($map['nameSpace'])) {
            $model->nameSpace = $map['nameSpace'];
        }
        if (isset($map['orderNumber'])) {
            $model->orderNumber = $map['orderNumber'];
        }
        if (isset($map['systemToken'])) {
            $model->systemToken = $map['systemToken'];
        }
        if (isset($map['systemType'])) {
            $model->systemType = $map['systemType'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
