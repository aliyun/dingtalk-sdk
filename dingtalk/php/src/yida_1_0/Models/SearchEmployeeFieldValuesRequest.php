<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models;

use AlibabaCloud\Tea\Model;

class SearchEmployeeFieldValuesRequest extends Model
{
    /**
     * @var string
     */
    public $targetFieldJson;

    /**
     * @var string
     */
    public $formUuid;

    /**
     * @var string
     */
    public $appType;

    /**
     * @var string
     */
    public $modifiedToTimeGMT;

    /**
     * @var string
     */
    public $systemToken;

    /**
     * @var string
     */
    public $modifiedFromTimeGMT;

    /**
     * @var string
     */
    public $language;

    /**
     * @var string
     */
    public $searchFieldJson;

    /**
     * @var string
     */
    public $originatorId;

    /**
     * @var string
     */
    public $userId;

    /**
     * @var string
     */
    public $createToTimeGMT;

    /**
     * @var string
     */
    public $createFromTimeGMT;
    protected $_name = [
        'targetFieldJson'     => 'targetFieldJson',
        'formUuid'            => 'formUuid',
        'appType'             => 'appType',
        'modifiedToTimeGMT'   => 'modifiedToTimeGMT',
        'systemToken'         => 'systemToken',
        'modifiedFromTimeGMT' => 'modifiedFromTimeGMT',
        'language'            => 'language',
        'searchFieldJson'     => 'searchFieldJson',
        'originatorId'        => 'originatorId',
        'userId'              => 'userId',
        'createToTimeGMT'     => 'createToTimeGMT',
        'createFromTimeGMT'   => 'createFromTimeGMT',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->targetFieldJson) {
            $res['targetFieldJson'] = $this->targetFieldJson;
        }
        if (null !== $this->formUuid) {
            $res['formUuid'] = $this->formUuid;
        }
        if (null !== $this->appType) {
            $res['appType'] = $this->appType;
        }
        if (null !== $this->modifiedToTimeGMT) {
            $res['modifiedToTimeGMT'] = $this->modifiedToTimeGMT;
        }
        if (null !== $this->systemToken) {
            $res['systemToken'] = $this->systemToken;
        }
        if (null !== $this->modifiedFromTimeGMT) {
            $res['modifiedFromTimeGMT'] = $this->modifiedFromTimeGMT;
        }
        if (null !== $this->language) {
            $res['language'] = $this->language;
        }
        if (null !== $this->searchFieldJson) {
            $res['searchFieldJson'] = $this->searchFieldJson;
        }
        if (null !== $this->originatorId) {
            $res['originatorId'] = $this->originatorId;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }
        if (null !== $this->createToTimeGMT) {
            $res['createToTimeGMT'] = $this->createToTimeGMT;
        }
        if (null !== $this->createFromTimeGMT) {
            $res['createFromTimeGMT'] = $this->createFromTimeGMT;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return SearchEmployeeFieldValuesRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['targetFieldJson'])) {
            $model->targetFieldJson = $map['targetFieldJson'];
        }
        if (isset($map['formUuid'])) {
            $model->formUuid = $map['formUuid'];
        }
        if (isset($map['appType'])) {
            $model->appType = $map['appType'];
        }
        if (isset($map['modifiedToTimeGMT'])) {
            $model->modifiedToTimeGMT = $map['modifiedToTimeGMT'];
        }
        if (isset($map['systemToken'])) {
            $model->systemToken = $map['systemToken'];
        }
        if (isset($map['modifiedFromTimeGMT'])) {
            $model->modifiedFromTimeGMT = $map['modifiedFromTimeGMT'];
        }
        if (isset($map['language'])) {
            $model->language = $map['language'];
        }
        if (isset($map['searchFieldJson'])) {
            $model->searchFieldJson = $map['searchFieldJson'];
        }
        if (isset($map['originatorId'])) {
            $model->originatorId = $map['originatorId'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }
        if (isset($map['createToTimeGMT'])) {
            $model->createToTimeGMT = $map['createToTimeGMT'];
        }
        if (isset($map['createFromTimeGMT'])) {
            $model->createFromTimeGMT = $map['createFromTimeGMT'];
        }

        return $model;
    }
}
