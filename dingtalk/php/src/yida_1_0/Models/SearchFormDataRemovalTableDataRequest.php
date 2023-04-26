<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vyida_1_0\Models;

use AlibabaCloud\Tea\Model;

class SearchFormDataRemovalTableDataRequest extends Model
{
    /**
     * @example APP_XCE0EVXS6DYG3YDYC5RD
     *
     * @var string
     */
    public $appType;

    /**
     * @example 2021-05-01
     *
     * @var string
     */
    public $createFromTimeGMT;

    /**
     * @example 2021-05-01
     *
     * @var string
     */
    public $createToTimeGMT;

    /**
     * @example FORM-GX866MC1NC1VOFF6WVQW33FD16E23L3CPMKVKA
     *
     * @var string
     */
    public $formUuid;

    /**
     * @example 2021-05-01
     *
     * @var string
     */
    public $modifiedFromTimeGMT;

    /**
     * @example 2021-09-10
     *
     * @var string
     */
    public $modifiedToTimeGMT;

    /**
     * @example 示例: 按照创建时间和文本组件值做升序排序则填写 {\"gmt_create\":\"+\",\"textField_1234\":\"+\"}。详情参考 https://www.yuque.com/yida/support/agb8im#CQro8
     *
     * @var string
     */
    public $orderConfigJson;

    /**
     * @example manager123
     *
     * @var string
     */
    public $originatorId;

    /**
     * @example 1
     *
     * @var int
     */
    public $pageNumber;

    /**
     * @example 100
     *
     * @var int
     */
    public $pageSize;

    /**
     * @example 支持2种检索规则{"numberField_l0c1cwiu":1}或者[{"key":"currentNodeName","value":"步凡","type":"TEXT","operator":"like","componentName":"TextField"}], 前一种规则仅仅做模糊匹配无法设置精确匹配, 第二种可以设置精确匹配条件。详情参考 https://www.yuque.com/yida/support/agb8im#F4S8e
     *
     * @var string
     */
    public $searchFieldJson;

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
        'searchFieldJson'     => 'searchFieldJson',
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
        if (null !== $this->searchFieldJson) {
            $res['searchFieldJson'] = $this->searchFieldJson;
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
     * @return SearchFormDataRemovalTableDataRequest
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
        if (isset($map['searchFieldJson'])) {
            $model->searchFieldJson = $map['searchFieldJson'];
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
