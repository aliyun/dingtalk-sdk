<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcustomer_service_1_0\Models\PageListTicketResponseBody;

use AlibabaCloud\Tea\Model;

class list_ extends Model
{
    /**
     * @description foreignId
     *
     * @var string
     */
    public $foreignId;

    /**
     * @description sourceId
     *
     * @var string
     */
    public $sourceId;

    /**
     * @description foreignName
     *
     * @var string
     */
    public $foreignName;

    /**
     * @description templateId
     *
     * @var string
     */
    public $templateId;

    /**
     * @description title
     *
     * @var string
     */
    public $title;

    /**
     * @description ticketId
     *
     * @var string
     */
    public $ticketId;

    /**
     * @description ticketStatus
     *
     * @var string
     */
    public $ticketStatus;

    /**
     * @description openInstanceId
     *
     * @var string
     */
    public $openInstanceId;

    /**
     * @description productionType
     *
     * @var int
     */
    public $productionType;

    /**
     * @description gmtCreate
     *
     * @var string
     */
    public $gmtCreate;

    /**
     * @description gmtModified
     *
     * @var string
     */
    public $gmtModified;

    /**
     * @description bizDataMap
     *
     * @var mixed[]
     */
    public $bizDataMap;
    protected $_name = [
        'foreignId'      => 'foreignId',
        'sourceId'       => 'sourceId',
        'foreignName'    => 'foreignName',
        'templateId'     => 'templateId',
        'title'          => 'title',
        'ticketId'       => 'ticketId',
        'ticketStatus'   => 'ticketStatus',
        'openInstanceId' => 'openInstanceId',
        'productionType' => 'productionType',
        'gmtCreate'      => 'gmtCreate',
        'gmtModified'    => 'gmtModified',
        'bizDataMap'     => 'bizDataMap',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->foreignId) {
            $res['foreignId'] = $this->foreignId;
        }
        if (null !== $this->sourceId) {
            $res['sourceId'] = $this->sourceId;
        }
        if (null !== $this->foreignName) {
            $res['foreignName'] = $this->foreignName;
        }
        if (null !== $this->templateId) {
            $res['templateId'] = $this->templateId;
        }
        if (null !== $this->title) {
            $res['title'] = $this->title;
        }
        if (null !== $this->ticketId) {
            $res['ticketId'] = $this->ticketId;
        }
        if (null !== $this->ticketStatus) {
            $res['ticketStatus'] = $this->ticketStatus;
        }
        if (null !== $this->openInstanceId) {
            $res['openInstanceId'] = $this->openInstanceId;
        }
        if (null !== $this->productionType) {
            $res['productionType'] = $this->productionType;
        }
        if (null !== $this->gmtCreate) {
            $res['gmtCreate'] = $this->gmtCreate;
        }
        if (null !== $this->gmtModified) {
            $res['gmtModified'] = $this->gmtModified;
        }
        if (null !== $this->bizDataMap) {
            $res['bizDataMap'] = $this->bizDataMap;
        }

        return $res;
    }

    /**
     * @param array $map
     *
     * @return list_
     */
    public static function fromMap($map = [])
    {
        $model = new self();
        if (isset($map['foreignId'])) {
            $model->foreignId = $map['foreignId'];
        }
        if (isset($map['sourceId'])) {
            $model->sourceId = $map['sourceId'];
        }
        if (isset($map['foreignName'])) {
            $model->foreignName = $map['foreignName'];
        }
        if (isset($map['templateId'])) {
            $model->templateId = $map['templateId'];
        }
        if (isset($map['title'])) {
            $model->title = $map['title'];
        }
        if (isset($map['ticketId'])) {
            $model->ticketId = $map['ticketId'];
        }
        if (isset($map['ticketStatus'])) {
            $model->ticketStatus = $map['ticketStatus'];
        }
        if (isset($map['openInstanceId'])) {
            $model->openInstanceId = $map['openInstanceId'];
        }
        if (isset($map['productionType'])) {
            $model->productionType = $map['productionType'];
        }
        if (isset($map['gmtCreate'])) {
            $model->gmtCreate = $map['gmtCreate'];
        }
        if (isset($map['gmtModified'])) {
            $model->gmtModified = $map['gmtModified'];
        }
        if (isset($map['bizDataMap'])) {
            $model->bizDataMap = $map['bizDataMap'];
        }

        return $model;
    }
}
