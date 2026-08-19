<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models;

use AlibabaCloud\Tea\Model;

class AISaleGetMemoryRequest extends Model
{
    /**
     * @var string
     */
    public $creatorId;

    /**
     * @var string
     */
    public $cursor;

    /**
     * @var string
     */
    public $customerScopeId;

    /**
     * @var string
     */
    public $entityId;

    /**
     * @var string[]
     */
    public $entityIds;

    /**
     * @var string
     */
    public $entityType;

    /**
     * @var string
     */
    public $keyword;

    /**
     * @var string
     */
    public $memoryCategory;

    /**
     * @var int
     */
    public $minImportance;

    /**
     * @var int
     */
    public $pageSize;

    /**
     * @var string
     */
    public $userId;
    protected $_name = [
        'creatorId' => 'creatorId',
        'cursor' => 'cursor',
        'customerScopeId' => 'customerScopeId',
        'entityId' => 'entityId',
        'entityIds' => 'entityIds',
        'entityType' => 'entityType',
        'keyword' => 'keyword',
        'memoryCategory' => 'memoryCategory',
        'minImportance' => 'minImportance',
        'pageSize' => 'pageSize',
        'userId' => 'userId',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->creatorId) {
            $res['creatorId'] = $this->creatorId;
        }
        if (null !== $this->cursor) {
            $res['cursor'] = $this->cursor;
        }
        if (null !== $this->customerScopeId) {
            $res['customerScopeId'] = $this->customerScopeId;
        }
        if (null !== $this->entityId) {
            $res['entityId'] = $this->entityId;
        }
        if (null !== $this->entityIds) {
            $res['entityIds'] = $this->entityIds;
        }
        if (null !== $this->entityType) {
            $res['entityType'] = $this->entityType;
        }
        if (null !== $this->keyword) {
            $res['keyword'] = $this->keyword;
        }
        if (null !== $this->memoryCategory) {
            $res['memoryCategory'] = $this->memoryCategory;
        }
        if (null !== $this->minImportance) {
            $res['minImportance'] = $this->minImportance;
        }
        if (null !== $this->pageSize) {
            $res['pageSize'] = $this->pageSize;
        }
        if (null !== $this->userId) {
            $res['userId'] = $this->userId;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return AISaleGetMemoryRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['creatorId'])) {
            $model->creatorId = $map['creatorId'];
        }
        if (isset($map['cursor'])) {
            $model->cursor = $map['cursor'];
        }
        if (isset($map['customerScopeId'])) {
            $model->customerScopeId = $map['customerScopeId'];
        }
        if (isset($map['entityId'])) {
            $model->entityId = $map['entityId'];
        }
        if (isset($map['entityIds'])) {
            if (!empty($map['entityIds'])) {
                $model->entityIds = $map['entityIds'];
            }
        }
        if (isset($map['entityType'])) {
            $model->entityType = $map['entityType'];
        }
        if (isset($map['keyword'])) {
            $model->keyword = $map['keyword'];
        }
        if (isset($map['memoryCategory'])) {
            $model->memoryCategory = $map['memoryCategory'];
        }
        if (isset($map['minImportance'])) {
            $model->minImportance = $map['minImportance'];
        }
        if (isset($map['pageSize'])) {
            $model->pageSize = $map['pageSize'];
        }
        if (isset($map['userId'])) {
            $model->userId = $map['userId'];
        }

        return $model;
    }
}
