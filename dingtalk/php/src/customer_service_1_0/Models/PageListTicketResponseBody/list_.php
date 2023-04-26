<?php

// This file is auto-generated, don't edit it. Thanks.

namespace AlibabaCloud\SDK\Dingtalk\Vcustomer_service_1_0\Models\PageListTicketResponseBody;

use AlibabaCloud\Tea\Model;

class list_ extends Model
{
    /**
     * @var mixed[]
     */
    public $bizDataMap;

    /**
     * @var string
     */
    public $foreignId;

    /**
     * @var string
     */
    public $foreignName;

    /**
     * @var string
     */
    public $gmtCreate;

    /**
     * @var string
     */
    public $gmtModified;

    /**
     * @var string
     */
    public $openInstanceId;

    /**
     * @var int
     */
    public $productionType;

    /**
     * @var string
     */
    public $sourceId;

    /**
     * @var string
     */
    public $templateId;

    /**
     * @var string
     */
    public $ticketId;

    /**
     * @var string
     */
    public $ticketStatus;

    /**
     * @var string
     */
    public $title;
    protected $_name = [
        'bizDataMap'     => 'bizDataMap',
        'foreignId'      => 'foreignId',
        'foreignName'    => 'foreignName',
        'gmtCreate'      => 'gmtCreate',
        'gmtModified'    => 'gmtModified',
        'openInstanceId' => 'openInstanceId',
        'productionType' => 'productionType',
        'sourceId'       => 'sourceId',
        'templateId'     => 'templateId',
        'ticketId'       => 'ticketId',
        'ticketStatus'   => 'ticketStatus',
        'title'          => 'title',
    ];

    public function validate()
    {
    }

    public function toMap()
    {
        $res = [];
        if (null !== $this->bizDataMap) {
            $res['bizDataMap'] = $this->bizDataMap;
        }
        if (null !== $this->foreignId) {
            $res['foreignId'] = $this->foreignId;
        }
        if (null !== $this->foreignName) {
            $res['foreignName'] = $this->foreignName;
        }
        if (null !== $this->gmtCreate) {
            $res['gmtCreate'] = $this->gmtCreate;
        }
        if (null !== $this->gmtModified) {
            $res['gmtModified'] = $this->gmtModified;
        }
        if (null !== $this->openInstanceId) {
            $res['openInstanceId'] = $this->openInstanceId;
        }
        if (null !== $this->productionType) {
            $res['productionType'] = $this->productionType;
        }
        if (null !== $this->sourceId) {
            $res['sourceId'] = $this->sourceId;
        }
        if (null !== $this->templateId) {
            $res['templateId'] = $this->templateId;
        }
        if (null !== $this->ticketId) {
            $res['ticketId'] = $this->ticketId;
        }
        if (null !== $this->ticketStatus) {
            $res['ticketStatus'] = $this->ticketStatus;
        }
        if (null !== $this->title) {
            $res['title'] = $this->title;
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
        if (isset($map['bizDataMap'])) {
            $model->bizDataMap = $map['bizDataMap'];
        }
        if (isset($map['foreignId'])) {
            $model->foreignId = $map['foreignId'];
        }
        if (isset($map['foreignName'])) {
            $model->foreignName = $map['foreignName'];
        }
        if (isset($map['gmtCreate'])) {
            $model->gmtCreate = $map['gmtCreate'];
        }
        if (isset($map['gmtModified'])) {
            $model->gmtModified = $map['gmtModified'];
        }
        if (isset($map['openInstanceId'])) {
            $model->openInstanceId = $map['openInstanceId'];
        }
        if (isset($map['productionType'])) {
            $model->productionType = $map['productionType'];
        }
        if (isset($map['sourceId'])) {
            $model->sourceId = $map['sourceId'];
        }
        if (isset($map['templateId'])) {
            $model->templateId = $map['templateId'];
        }
        if (isset($map['ticketId'])) {
            $model->ticketId = $map['ticketId'];
        }
        if (isset($map['ticketStatus'])) {
            $model->ticketStatus = $map['ticketStatus'];
        }
        if (isset($map['title'])) {
            $model->title = $map['title'];
        }

        return $model;
    }
}
