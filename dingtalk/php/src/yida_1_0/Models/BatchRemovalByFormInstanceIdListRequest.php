<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models;

use AlibabaCloud\Tea\Model;

class BatchRemovalByFormInstanceIdListRequest extends Model
{
    /**
     * @example APP_XCE0EVXS6DYG3YDYC5RD
     *
     * @var string
     */
    public $appType;

    /**
     * @example true
     *
     * @var bool
     */
    public $asynchronousExecution;

    /**
     * @example true
     *
     * @var bool
     */
    public $executeExpression;

    /**
     * @example FINST-J8766S91O2UYN87ZX3XOF1MY8MBA2912BSV0L24
     *
     * @var string[]
     */
    public $formInstanceIdList;

    /**
     * @example FORM-GX866MC1NC1VOFF6WVQW33FD16E23L3CPMKVKA
     *
     * @var string
     */
    public $formUuid;

    /**
     * @example 09866181UTZVVD4R3DC955FNKIM52HVPU5WWK7
     *
     * @var string
     */
    public $systemToken;

    /**
     * @example ding173982232112232
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'appType'               => 'appType',
        'asynchronousExecution' => 'asynchronousExecution',
        'executeExpression'     => 'executeExpression',
        'formInstanceIdList'    => 'formInstanceIdList',
        'formUuid'              => 'formUuid',
        'systemToken'           => 'systemToken',
        'userId'                => 'userId',
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
        if (null !== $this->asynchronousExecution) {
            $res['asynchronousExecution'] = $this->asynchronousExecution;
        }
        if (null !== $this->executeExpression) {
            $res['executeExpression'] = $this->executeExpression;
        }
        if (null !== $this->formInstanceIdList) {
            $res['formInstanceIdList'] = $this->formInstanceIdList;
        }
        if (null !== $this->formUuid) {
            $res['formUuid'] = $this->formUuid;
        }
        if (null !== $this->systemToken) {
            $res['systemToken'] = $this->systemToken;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return BatchRemovalByFormInstanceIdListRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['appType'])) {
            $model->appType = $map['appType'];
        }
        if (isset($map['asynchronousExecution'])) {
            $model->asynchronousExecution = $map['asynchronousExecution'];
        }
        if (isset($map['executeExpression'])) {
            $model->executeExpression = $map['executeExpression'];
        }
        if (isset($map['formInstanceIdList'])) {
            if (!empty($map['formInstanceIdList'])) {
                $model->formInstanceIdList = $map['formInstanceIdList'];
            }
        }
        if (isset($map['formUuid'])) {
            $model->formUuid = $map['formUuid'];
        }
        if (isset($map['systemToken'])) {
            $model->systemToken = $map['systemToken'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
