<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vhrm_1_0\Models\AISaleGetMemoryResponseBody\result;

use AlibabaCloud\Tea\Model;

class data extends Model
{
    /**
     * @var string
     */
    public $contactId;

    /**
     * @var string
     */
    public $corpId;

    /**
     * @var string
     */
    public $creatorId;

    /**
     * @var string
     */
    public $customerId;

    /**
     * @var string
     */
    public $entityId;

    /**
     * @var string
     */
    public $entityType;

    /**
     * @var string
     */
    public $extInfo;

    /**
     * @var int
     */
    public $gmtCreate;

    /**
     * @var int
     */
    public $gmtModified;

    /**
     * @var int
     */
    public $happenedAt;

    /**
     * @var int
     */
    public $importance;

    /**
     * @var string
     */
    public $memoryCategory;

    /**
     * @var string
     */
    public $memoryContent;

    /**
     * @var string
     */
    public $memoryId;

    /**
     * @var string
     */
    public $memoryTitle;

    /**
     * @var string
     */
    public $sourceActivityId;

    /**
     * @var string[]
     */
    public $tags;
    protected $_name = [
        'contactId' => 'contactId',
        'corpId' => 'corpId',
        'creatorId' => 'creatorId',
        'customerId' => 'customerId',
        'entityId' => 'entityId',
        'entityType' => 'entityType',
        'extInfo' => 'extInfo',
        'gmtCreate' => 'gmtCreate',
        'gmtModified' => 'gmtModified',
        'happenedAt' => 'happenedAt',
        'importance' => 'importance',
        'memoryCategory' => 'memoryCategory',
        'memoryContent' => 'memoryContent',
        'memoryId' => 'memoryId',
        'memoryTitle' => 'memoryTitle',
        'sourceActivityId' => 'sourceActivityId',
        'tags' => 'tags',
    ];

    public function validate() {}

    public function toMap()
    {
        $res = [];
        if (null !== $this->contactId) {
            $res['contactId'] = $this->contactId;
        }
        if (null !== $this->corpId) {
            $res['corpId'] = $this->corpId;
        }
        if (null !== $this->creatorId) {
            $res['creatorId'] = $this->creatorId;
        }
        if (null !== $this->customerId) {
            $res['customerId'] = $this->customerId;
        }
        if (null !== $this->entityId) {
            $res['entityId'] = $this->entityId;
        }
        if (null !== $this->entityType) {
            $res['entityType'] = $this->entityType;
        }
        if (null !== $this->extInfo) {
            $res['extInfo'] = $this->extInfo;
        }
        if (null !== $this->gmtCreate) {
            $res['gmtCreate'] = $this->gmtCreate;
        }
        if (null !== $this->gmtModified) {
            $res['gmtModified'] = $this->gmtModified;
        }
        if (null !== $this->happenedAt) {
            $res['happenedAt'] = $this->happenedAt;
        }
        if (null !== $this->importance) {
            $res['importance'] = $this->importance;
        }
        if (null !== $this->memoryCategory) {
            $res['memoryCategory'] = $this->memoryCategory;
        }
        if (null !== $this->memoryContent) {
            $res['memoryContent'] = $this->memoryContent;
        }
        if (null !== $this->memoryId) {
            $res['memoryId'] = $this->memoryId;
        }
        if (null !== $this->memoryTitle) {
            $res['memoryTitle'] = $this->memoryTitle;
        }
        if (null !== $this->sourceActivityId) {
            $res['sourceActivityId'] = $this->sourceActivityId;
        }
        if (null !== $this->tags) {
            $res['tags'] = $this->tags;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return data
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['contactId'])) {
            $model->contactId = $map['contactId'];
        }
        if (isset($map['corpId'])) {
            $model->corpId = $map['corpId'];
        }
        if (isset($map['creatorId'])) {
            $model->creatorId = $map['creatorId'];
        }
        if (isset($map['customerId'])) {
            $model->customerId = $map['customerId'];
        }
        if (isset($map['entityId'])) {
            $model->entityId = $map['entityId'];
        }
        if (isset($map['entityType'])) {
            $model->entityType = $map['entityType'];
        }
        if (isset($map['extInfo'])) {
            $model->extInfo = $map['extInfo'];
        }
        if (isset($map['gmtCreate'])) {
            $model->gmtCreate = $map['gmtCreate'];
        }
        if (isset($map['gmtModified'])) {
            $model->gmtModified = $map['gmtModified'];
        }
        if (isset($map['happenedAt'])) {
            $model->happenedAt = $map['happenedAt'];
        }
        if (isset($map['importance'])) {
            $model->importance = $map['importance'];
        }
        if (isset($map['memoryCategory'])) {
            $model->memoryCategory = $map['memoryCategory'];
        }
        if (isset($map['memoryContent'])) {
            $model->memoryContent = $map['memoryContent'];
        }
        if (isset($map['memoryId'])) {
            $model->memoryId = $map['memoryId'];
        }
        if (isset($map['memoryTitle'])) {
            $model->memoryTitle = $map['memoryTitle'];
        }
        if (isset($map['sourceActivityId'])) {
            $model->sourceActivityId = $map['sourceActivityId'];
        }
        if (isset($map['tags'])) {
            if (!empty($map['tags'])) {
                $model->tags = $map['tags'];
            }
        }

        return $model;
    }
}
