<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models;

use AlibabaCloud\Tea\Model;

class SearchFormDataSecondGenerationNoTableFieldRequest extends Model
{
    /**
     * @description 宜搭应用编码
     *
     * @var string
     */
    public $appType;

    /**
     * @description 创建时间起始值
     *
     * @var string
     */
    public $createFromTimeGMT;

    /**
     * @description 创建时间终止值
     *
     * @var string
     */
    public $createToTimeGMT;

    /**
     * @description 表单编码
     *
     * @var string
     */
    public $formUuid;

    /**
     * @description 修改时间起始值
     *
     * @var string
     */
    public $modifiedFromTimeGMT;

    /**
     * @description 修改时间终止值
     *
     * @var string
     */
    public $modifiedToTimeGMT;

    /**
     * @description 排序规则
     *
     * @var string
     */
    public $orderConfigJson;

    /**
     * @description 表单提交人的钉钉userId
     *
     * @var string
     */
    public $originatorId;

    /**
     * @description 当前第几页
     *
     * @var int
     */
    public $pageNumber;

    /**
     * @description 分页大小
     *
     * @var int
     */
    public $pageSize;

    /**
     * @description 用于检索表单实例数据的检索条件
     *
     * @var string
     */
    public $searchCondition;

    /**
     * @description 宜搭应用秘钥
     *
     * @var string
     */
    public $systemToken;

    /**
     * @description 钉钉userId
     *
     * @var string
     */
    public $userId;
    protected $_name = [
        'appType'             => 'appType',
        'createFromTimeGMT'   => 'createFromTimeGMT',
        'createToTimeGMT'     => 'createToTimeGMT',
        'formUuid'            => 'formUuid',
        'modifiedFromTimeGMT' => 'modifiedFromTimeGMT',
        'modifiedToTimeGMT'   => 'modifiedToTimeGMT',
        'orderConfigJson'     => 'orderConfigJson',
        'originatorId'        => 'originatorId',
        'pageNumber'          => 'pageNumber',
        'pageSize'            => 'pageSize',
        'searchCondition'     => 'searchCondition',
        'systemToken'         => 'systemToken',
        'userId'              => 'userId',
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
        if (null !== $this->createFromTimeGMT) {
            $res['createFromTimeGMT'] = $this->createFromTimeGMT;
        }
        if (null !== $this->createToTimeGMT) {
            $res['createToTimeGMT'] = $this->createToTimeGMT;
        }
        if (null !== $this->formUuid) {
            $res['formUuid'] = $this->formUuid;
        }
        if (null !== $this->modifiedFromTimeGMT) {
            $res['modifiedFromTimeGMT'] = $this->modifiedFromTimeGMT;
        }
        if (null !== $this->modifiedToTimeGMT) {
            $res['modifiedToTimeGMT'] = $this->modifiedToTimeGMT;
        }
        if (null !== $this->orderConfigJson) {
            $res['orderConfigJson'] = $this->orderConfigJson;
        }
        if (null !== $this->originatorId) {
            $res['originatorId'] = $this->originatorId;
        }
        if (null !== $this->pageNumber) {
            $res['pageNumber'] = $this->pageNumber;
        }
        if (null !== $this->pageSize) {
            $res['pageSize'] = $this->pageSize;
        }
        if (null !== $this->searchCondition) {
            $res['searchCondition'] = $this->searchCondition;
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
     * @return SearchFormDataSecondGenerationNoTableFieldRequest
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['appType'])) {
            $model->appType = $map['appType'];
        }
        if (isset($map['createFromTimeGMT'])) {
            $model->createFromTimeGMT = $map['createFromTimeGMT'];
        }
        if (isset($map['createToTimeGMT'])) {
            $model->createToTimeGMT = $map['createToTimeGMT'];
        }
        if (isset($map['formUuid'])) {
            $model->formUuid = $map['formUuid'];
        }
        if (isset($map['modifiedFromTimeGMT'])) {
            $model->modifiedFromTimeGMT = $map['modifiedFromTimeGMT'];
        }
        if (isset($map['modifiedToTimeGMT'])) {
            $model->modifiedToTimeGMT = $map['modifiedToTimeGMT'];
        }
        if (isset($map['orderConfigJson'])) {
            $model->orderConfigJson = $map['orderConfigJson'];
        }
        if (isset($map['originatorId'])) {
            $model->originatorId = $map['originatorId'];
        }
        if (isset($map['pageNumber'])) {
            $model->pageNumber = $map['pageNumber'];
        }
        if (isset($map['pageSize'])) {
            $model->pageSize = $map['pageSize'];
        }
        if (isset($map['searchCondition'])) {
            $model->searchCondition = $map['searchCondition'];
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
